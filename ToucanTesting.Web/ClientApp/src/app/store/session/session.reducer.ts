import { SessionState } from './session.state';
import { login, loginSuccess, loginError } from './session.actions';
import { createReducer, on } from '@ngrx/store';

export const initialState: SessionState = {
    info: null,
    user: {},
    request: null,
    login: {
        creds: null,
        provider: null,
        code: null
    },
    profile: null,
    isLoggedIn: false,
    is2faRequired: true,
    error: null,
    organizationChanged: false
};

export const sessionReducer = createReducer(initialState,
    on(login, (state, payload) => {
        return {
            ...state,
            login: {
                ...state.login,
                creds: payload
            },
            error: null
        };
    }),

    on(loginError, (state, payload) => {
        let error;
        if (payload.twofactorauth_status && payload.twofactorauth_status === 'invalid two factor code')
            error = 'The security code you entered was invalid.';
        else if (payload.twofactorauth_status) error = null;
        else error = payload.error_description || 'An unknown error has occurred!';

        return {
            ...state,
            isLoggedIn: false,
            is2faRequired: !!payload.twofactorauth_status,
            error
        };
    }),

    on(loginSuccess, (state, payload) => {
        return {
            ...state,
            isLoggedIn: true,
            info: payload,
            error: null
        };
    })
);
