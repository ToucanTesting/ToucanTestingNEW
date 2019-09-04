import { Credentials } from '@toucan/models';

export interface LoginState {
    creds: Credentials;
    provider: string;
    code: string;
}
