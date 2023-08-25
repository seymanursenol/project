import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {  HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { ContentComponent } from './content/content.component';

//
import {MatIconModule} from '@angular/material/icon';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RestorantListComponent } from './restorant-list/restorant-list.component';
import { RestCategoryComponent } from './rest-category/rest-category.component';
import { RestProductComponent } from './rest-product/rest-product.component';
import { RestProListComponent } from './rest-product/rest-pro-list/rest-pro-list.component';
import { SignupPageComponent } from './signup-page/signup-page.component';
import { AdminComponent } from './admin/admin.component';
import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { SiparisComponent } from './admin/siparis/siparis.component';
import { HomePageComponent } from './admin/home-page/home-page.component';
import { PAddComponent } from './admin/p-add/p-add.component';
import { PDeleteComponent } from './admin/p-delete/p-delete.component';
import { AdminLoginPageComponent } from './admin/admin-login-page/admin-login-page.component';
import { PUpdateComponent } from './admin/p-update/p-update.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ContentComponent,
    LoginPageComponent,
    RestorantListComponent,
    RestCategoryComponent,
    RestProductComponent,
    RestProListComponent,
    SignupPageComponent,
    AdminComponent,
    AdminPageComponent,
    SiparisComponent,
    HomePageComponent,
    PAddComponent,
    PDeleteComponent,
    AdminLoginPageComponent,
    PUpdateComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

