import {Component,OnInit} from '@angular/core';
import { Transaction } from './Transaction';
import { TransactionService } from './transactions.service';
import { Sample } from './sample';

@Component({
    selector:'app-transaction',
    templateUrl:'./transaction.component.html'
})

export class TransactionComponent implements OnInit{
    transactions: Transaction[] = [];
    first:number=0;
    last:number=0;
    totalrescords:number=0;
    loading:boolean=false;
    data: any;

    constructor(private apiService: TransactionService) { }

    ngOnInit(){
        this.loadData();
    }

    loadData()
    {   this.loading=true;
        this.apiService.getData().subscribe({
           next: (response) => {
                this.transactions = response.data;
                this.loading=false;
            },
            error:(error) => {
                console.error('Error fetching transaction data', error);
                this.loading=false;
            }
        });

    }

    pageChange($event:any)
    {

    }

}