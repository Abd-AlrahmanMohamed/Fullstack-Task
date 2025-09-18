import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IProduct } from '../../../ViewModels/iproduct';
import { environment } from '../../../enviroments/environment';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css'],
})
export class AddProductComponent implements OnInit {
  products: IProduct[] = [];
  productForm = new FormGroup({
    name: new FormControl('', Validators.required),
    category: new FormControl('', Validators.required),
    image: new FormControl('', Validators.required),
    productCode: new FormControl('', Validators.required),
    MinimumQuantity: new FormControl('', Validators.required),
    DiscountRate: new FormControl('', Validators.required),
    price: new FormControl('', Validators.required),
  });

 name() {
  return this.productForm.get('name');
}

category() {
  return this.productForm.get('category');
}

image() {
  return this.productForm.get('image');
}

productCode() {
  return this.productForm.get('productCode');
}

minimumQuantity() {
  return this.productForm.get('MinimumQuantity');
}

discountRate() {
  return this.productForm.get('DiscountRate');
}

price() {
  return this.productForm.get('price');
}


  constructor(
    private route: ActivatedRoute,
    private hClient: HttpClient,
    private router: Router
  ) {}

  ngOnInit() {}

  onSubmit() {
    if (this.productForm.valid) {
      const formData = this.productForm.value;

      this.hClient
        .post<IProduct>(`${environment.apiUrl}Product/add-product`, formData)
        .subscribe({
          next: (response) => {
            console.log(' Backend response:', response);

            setTimeout(() => {
              this.router.navigate(['/']);
            }, 2000);
          },
          error: (error) => {
            console.error(' Backend error:', error);
          },
        });
    } else {
      console.warn(' Form is invalid');
      this.productForm.markAllAsTouched();
    }
  }
}
