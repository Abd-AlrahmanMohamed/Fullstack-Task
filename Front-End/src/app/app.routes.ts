import { Routes } from '@angular/router';
import { RegisterComponent } from '../Components/Register/Register.component';
import { LoginComponent } from '../Components/Login/Login.component';
import { ProductComponent } from '../Components/Product/Product.component';
import { AddProductComponent} from '../Component/Product/AddProduct/AddProduct.component';

export const routes: Routes = [
  { path: 'adduser', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: '', component: ProductComponent },
  {path: 'add-product', component: AddProductComponent}
];

