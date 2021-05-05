import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/_models/product';
import { ProductService } from 'src/app/_services/product.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-product-info',
  templateUrl: './product-info.component.html',
  styleUrls: ['./product-info.component.css'],
})
export class ProductInfoComponent implements OnInit {

  product: Product | undefined;
  productId: number = 0;

 
  // product: Product = {
  //   id: 0,
  //   name: 'ccc',
  //   description: 'ccc',
  //   imageUrl: 'http://dummyimage.com/300x200.png/5fa2dd/ffffff',
  //   price: 10,
  // };

  constructor(
    private productService: ProductService,
    private router: Router,
    private route: ActivatedRoute
  ) {}


  ngOnInit(): void {
    // const id = this.route.snapshot.paramMap.get('id');
    // this.productId = id ? +id : 0

    
    this.productId = +this.route.snapshot.paramMap.get('id')!;
    if (this.productId) {
      this.productService.getProduct(this.productId).subscribe(
        (product) => (this.product = product),
        (error) => {
          this.router.navigate(['/product-info']);
        }
      );
    } else {
      this.product = new Product();
    }
  }


  // addProduct() {
  //   this.productService.addProduct(this.product).subscribe(
  //     (product) => {
  //       this.router.navigate(['/products']);
  //       console.log(product);
  //     },
  //     (error) => {
  //       console.error(error);
  //     }
  //   );
  // }
  submitProduct() {
    if (this.productId == 0) {
      this.productService.addProduct(this.product!).subscribe(
        (product) => {
          this.router.navigate(['/products']);
        },
        (error) => {
          console.log(error);
        }
      );
    } else {
      this.productService.updateProduct(this.product!).subscribe(
        (product) => {
          this.router.navigate(['/products']);
        },
        (error) => {
          console.log(error);
        }
      );
    }
  }

}
