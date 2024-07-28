import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';


interface SalesModel {
  customerName: string;
  customerId: number;
  discount: number;
  cash: number;
  total: number;
  orderNo: number;
  details: any[]
}
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})


export class HomeComponent {

  baseUrl = "https://localhost:7066/api/";
    products: any[]=[];
    Cats: any[]=[];
    fillterProducts: any[]=[];
    customers: any[]=[];
  customerName: any;
  salesDetail: any[] = [];

 
  model: SalesModel = 
   

    { customerName: "", customerId: 0, discount: 0, cash: 0, total: 0, orderNo: 0, details:[] }
  
  
  
  constructor(private xhttp: HttpClient) {

    this.model.cash = 0;
    this.xhttp.get(this.baseUrl +"Product/getAllProducts/")
      .subscribe(result => {

        this.products = result as any[];
        this.fillterProducts = result as any[];
        console.log(result);
      });



    this.xhttp.get(this.baseUrl + "Category/getAllCategory/")
      .subscribe(result => {

        this.Cats = result as any[];
        console.log(result);
      });


    this.xhttp.get(this.baseUrl + "Product/getCustomer/")
      .subscribe(result => {

        this.customers = result as any[];
        console.log(result);
      });

  }

  FilterProductsbyCategory(catId: number) {


    this.fillterProducts = this.products.filter(function (item){
      return item.categoryId == catId;
    })

    
  }
  toggleCustomer() {
    let popupMulti = document.querySelector('.multi-pop-up');
    popupMulti?.classList.toggle('show');

    
  }
  changeCustomer(item: any) {
    this.model.customerName = item.name;
    this.model.customerId = item.id;
    this.toggleCustomer();
  }

  AddItem(item: any) {
    this.salesDetail.push({ product: item, qty: 1, total: item.price });
    console.log(this.salesDetail);
    this.CalculateTotals();

  }

  RemoveProduct(index: number) {
    this.salesDetail.splice(index, 1);
    this.CalculateTotals();

  }

  IncreaseQty(item: any) {
    item.qty += 1;
    item.total = item.qty * item.product.price;
    this.CalculateTotals();

  }

  DecreaseQty(item: any) {
    if (item.qty <= 1) {
      return;
    }
    item.qty -= 1;
    item.total = item.qty * item.product.price;
   this.CalculateTotals();
  }

  CalculateTotals() {

    this.model.total = 0;

    for (var i = 0; i < this.salesDetail.length; i++) {
      this.model.total += this.salesDetail[i].total;
    }


    if (this.model.discount > this.model.total) {
      this.model.discount = this.model.total;
    }
    if (this.model.discount < 1) {
      this.model.discount = 0;
    }
   
    
    this.model.cash = this.model.total - this.model.discount;
  }

  ClearDetails() {
    this.salesDetail = [];
  }

  Save() {
    if (this.salesDetail.length < 1) {
      alert("برجاء اضافة منتجات اولا ")
      return;
    }
    if (this.model.customerId == 0) {
      alert("برجاء اختيار العميل اولا ")
      return;
    }
    this.model.details = this.salesDetail;

    this.xhttp.post(this.baseUrl + "Product/saveSales", this.model).subscribe(result => {
      alert("تم الحفظ بنجاخ");
    }, error => {
      alert("خطا في الحفظ ");
    });
    this.salesDetail = [];
    console.log(this.model);
  }
}
