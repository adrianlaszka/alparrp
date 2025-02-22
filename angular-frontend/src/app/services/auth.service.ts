import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private clientId = '1342799094791409694';  // Cseréld le a sajátodra!
  private redirectUri = 'http://localhost:4200/auth/callback';

  constructor() { }

  loginWithDiscord(): void {
    const discordAuthUrl = `https://discord.com/oauth2/authorize?client_id=${this.clientId}&redirect_uri=${encodeURIComponent(this.redirectUri)}&response_type=token&scope=identify%20guilds`;
    window.location.href = discordAuthUrl;
  }
}
