import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StoreModule as NgRxStoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';

// Reducers
import { sessionReducer } from './session/session.reducer';

// Effects
import { SessionEffects } from './session/session.effects';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    NgRxStoreModule.forRoot({
      session: sessionReducer
    }),
    EffectsModule.forRoot([
      SessionEffects
    ])
  ],
})
export class StoreModule { }
