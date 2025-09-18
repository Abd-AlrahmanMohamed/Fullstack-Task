import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { IProduct } from '../../../ViewModels/iproduct';
import { environment } from '../../../enviroments/environment';

@Component({
  selector: 'app-get-product-byid',
  templateUrl: './get-product-byid.component.html',
  styleUrls: ['./get-product-byid.component.css']
})
export class GetProductByidComponent implements OnInit {
products: IProduct[] = [];
 

  constructor(
    private route: ActivatedRoute,
    private hClient: HttpClient,
    private router: Router
  ) {}

  ngOnInit() {
    const prodId = this.route.snapshot.paramMap.get('id');
    this.GetById(+prodId!).subscribe((product) => {
      this.products = product;
    });

  }


  GetById(productId: number): Observable<IProduct> {
    this.hClient
      .get<IProduct>(
        `${environment.apiUrl}Product/get-product-by-id/${productId}`
      )
      .subscribe({
        next: (response) => {
          console.log(' product response:', response);
        },
      });
  }



}
