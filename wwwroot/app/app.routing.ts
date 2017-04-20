import { ModuleWithProviders } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from './components/home/home.component';
import { ContractComponent } from './components/contract/contract.component';
import { LoginComponent } from './components/login/login.component';
import { SaleComponent } from './components/sale/sale.component';
import { RentalComponent } from './components/rental/rental.component';


const appRoutes: Routes = [
    {
        path: "",
        component: HomeComponent
    },
    {
        path: "home",
        redirectTo: ""
    },
    {
        path: "contract",
        component: ContractComponent
    },
    {
        path: "login",
        component: LoginComponent
    },
     {
        path: "rental",
        component: RentalComponent
    },
    {
        path: "sale",
        component: SaleComponent
    }
];
    
export const AppRoutingProviders: any[] = [
];

export const AppRouting: ModuleWithProviders = RouterModule.forRoot(appRoutes);