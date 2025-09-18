import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IProduct } from '../../ViewModels/iproduct';
import { environment } from '../../enviroments/environment';

@Component({
  selector: 'app-Product',
  templateUrl: './Product.component.html',
  styleUrls: ['./Product.component.css'],
})
export class ProductComponent implements OnInit {
  products: IProduct[] = [];

  constructor(
    private route: ActivatedRoute,
    private hClient: HttpClient,
    private router: Router
  ) {}

  ngOnInit() {
    this.GetAll().subscribe((res: IProduct[]) => {
      this.products = res;
    });
  }

  GetAll(): Observable<IProduct> {
    this.hClient
      .get<IProduct>(`${environment.apiUrl}Product/get-all-products`)
      .subscribe({
        next: (response) => {
          console.log(' product response:', response);
        },
      });
  }
}
