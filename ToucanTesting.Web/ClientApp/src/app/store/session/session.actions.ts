import { props } from '@ngrx/store';
import { TokenResponse } from '@toucan/models';
import { TokenErrorResponse, Credentials } from '@toucan/models';
import { createAction } from '@ngrx/store';

export const login = createAction('[Session] Login', props<Credentials>());
export const loginError = createAction('[Session] Login Error', props<TokenErrorResponse>());
export const loginSuccess = createAction('[Session] Login Success', props<TokenResponse>());
export const loadUser = createAction('[Session] Load User');
export const loadProfile = createAction('[Session] Load Profile');

