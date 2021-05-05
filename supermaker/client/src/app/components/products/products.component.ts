import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/_services/product.service';
import { PRODUCTS_DATA } from '../../_data/products';
import { Product } from '../../_models/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {


 
  constructor(private productService: ProductService) {}
  products: Product[] = [];
  ngOnInit(): void {
    this.productService.getProducts().subscribe(
      (products) => {
        this.products = products;
      },
      (error) => {
        console.error(error);
      }
    );
  }


}
