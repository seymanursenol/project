import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentComponent } from './content/content.component';
import { LoginPageComponent } from './login-page/login-page.component';

import { RestorantListComponent } from './restorant-list/restorant-list.component';
import { NavbarComponent } from './navbar/navbar.component';
import { RestProductComponent } from './rest-product/rest-product.component';
import { SignupPageComponent } from './signup-page/signup-page.component';
import { SiparisComponent } from './admin/siparis/siparis.component';
import { HomePageComponent } from './admin/home-page/home-page.component';
import { AdminComponent } from './admin/admin.component';
import { PAddComponent } from './admin/p-add/p-add.component';
import { PDeleteComponent } from './admin/p-delete/p-delete.component';
import { AdminLoginPageComponent } from './admin/admin-login-page/admin-login-page.component';
import { PUpdateComponent } from './admin/p-update/p-update.component';


const routes: Routes = [
   {path: '', component: ContentComponent},
   {path: 'navbar', component: NavbarComponent},
   {path: 'login-page', component: LoginPageComponent},

   {path: 'restorant', component: RestorantListComponent},

   {path: 'product/restId/:restorantId', component: RestProductComponent},
   {path: 'kayitOl', component: SignupPageComponent},

   {path: 'restorant/category/:id', component:RestorantListComponent},

   {path: 'restProduct', component: RestProductComponent},

   {path: 'siparis', component: SiparisComponent},
   {path: 'anasayfa', component: HomePageComponent},
   {path: 'AdminBasvuru', component: AdminComponent},

   {path: 'AdminLoginPage', component: AdminLoginPageComponent},
   {path: 'Create', component: PAddComponent},
   {path: 'Delete', component: PDeleteComponent},
   {path: 'Update', component:PUpdateComponent}

 ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
