import { Component, Input, OnInit } from '@angular/core';
import { Product } from '../../_models/product';
import { ProductService } from 'src/app/_services/product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  @Input() product!: Product;
  constructor() { }
  ngOnInit(): void {
    }
}

