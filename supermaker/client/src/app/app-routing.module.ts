import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './components/products/products.component';
import { Routes, RouterModule } from '@angular/router';
import { CartsComponent } from './components/carts/carts.component';
import { ProductInfoComponent } from './components/product-info/product-info.component';

const routes: Routes = [
  {path: '', redirectTo: "products", pathMatch: "full"},
  {path: 'products', component: ProductsComponent},
  {path: "carts", component: CartsComponent},
  {path: "product-info", component: ProductInfoComponent},
  {path: "product-info/:id", component: ProductInfoComponent},
  
];

// @NgModule({
//   declarations: [],
//   imports: [CommonModule],
// })

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
