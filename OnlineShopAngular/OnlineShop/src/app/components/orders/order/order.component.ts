import { Component, OnInit, Input } from '@angular/core';
import { Order } from 'src/app/models/orders/order';
import { Stage } from 'src/app/models/orders/stage';
import { Product } from 'src/app/models/orders/product';
import { Category } from 'src/app/models/orders/category';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  @Input()
  order : Order;
  @Input()
  stage : Stage;
  @Input()
  product : Product;
  @Input()
  category: Category;

  constructor() { }

  ngOnInit() {
  }

  getOrderPrice(): number{
      return +(this.order.Amount * this.order.ProductPrice).toFixed(2);
  }

}
