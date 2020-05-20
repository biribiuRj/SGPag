import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Area } from "../../modelo/area";
//import { } from "";

@Injectable({
  providedIn:"root"
})

export class ServicoArea {

  private baseURL: string;
  private _area: Area;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json; charset=UTF-8');
  }
  public verificarArea(area: Area): Observable<Area> {
    return this.http.post<Area>(this.baseURL + "api/area/verificarUsuario", JSON.stringify(area), { headers: this.headers });
  }
  public cadastrarArea(area: Area): Observable<Area> {
    return this.http.post<Area>(this.baseURL + "api/area", JSON.stringify(area), { headers: this.headers });
  }
  public obterTodos(): Observable<Area[]> {
    return this.http.get<Area[]>(this.baseURL + "api/area");
  }
  public deletarArea(area: Area): Observable<Area[]> {
    return this.http.get<Area[]>(this.baseURL + "api/area/deletar");
  }
}

