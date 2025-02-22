import { Routes } from '@angular/router';
import { LandingComponent } from './components/landing/landing.component';

export const appRoutes: Routes = [
  { path: '', component: LandingComponent },
  { path: '**', redirectTo: '' }
];
