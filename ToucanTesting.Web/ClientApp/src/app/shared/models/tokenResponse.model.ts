// tslint:disable: variable-name

export class TokenResponse {
    status: number;
    access_token: string;
    token_type: string;
    expires_in: number;
    refresh_token: string;
    userName: string;
    domain: string;
    api: string;
    refreshtokenlifetime: string;
    ['.issued']: Date;
    ['.expires']: Date;
}
