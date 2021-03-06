import { Injectable } from '@angular/core';
import { Member } from './member.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class MembersService {

  constructor(private http: HttpClient) {

  }
  readonly _baseUrl = "https://localhost:44336/api/Member";

  formData: Member = new Member();
  list: any;

  postMember() {
    return this.http.post(this._baseUrl, this.formData);
  }

  putMember() {
    return this.http.put(`${this._baseUrl}/${this.formData.id}`, this.formData);
  }
  deleteMember(id: number) {
    return this.http.delete(`${this._baseUrl}/${id}`);
  }

  refreshList() {
    this.http.get(this._baseUrl)
      .toPromise()
      .then(res => this.list = res as Member[]);
  }

}
