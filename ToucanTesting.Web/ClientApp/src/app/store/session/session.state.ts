import { TokenResponse } from '@toucan/models';
import { LoginState } from '../shared';
import { Profile } from '@toucan/models';

export interface SessionState {
    info: TokenResponse;
    user: any;
    request: {
        apiUrl: string;
        authToken: string;
        userId: string;
    };
    login: LoginState;
    profile: Profile;
    isLoggedIn: boolean;
    is2faRequired: boolean;
    error: string;
    organizationChanged: boolean;
}
