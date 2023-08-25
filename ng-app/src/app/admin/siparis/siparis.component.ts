import { Component } from '@angular/core';
import { SiparisService } from 'src/app/Service/siparis.service';
import { Siparis } from 'src/app/models/Siparis';

@Component({
  selector: 'siparis',
  templateUrl: './siparis.component.html',
  styleUrls: ['./siparis.component.css']
})
export class SiparisComponent {

  siparisler: Siparis[];

  mode :string= "";

  constructor(private siparisService: SiparisService){}

  ngOnInit(): void {
    const buttons = document.querySelectorAll('.custom-btn');
    buttons.forEach(button => {
      button.addEventListener('click', () => {
        buttons.forEach(btn => {
          btn.classList.remove('active');
        });

        button.classList.add('active');
      });
    });


    this.getSiparis();
  }

  getSiparis(){
    this.siparisService.getSiparis().subscribe(siparisler =>{
      this.siparisler= siparisler;

      console.log(siparisler);
    })
  }

  H(){
    this.mode="Hazırlanıyor.";
  }
  Y(){
    this.mode="Yolda.";
  }
  T(){
    this.mode="Teslim Edildi.";
  }
  Iptal(){
    this.mode="İptal Edildi.";
  }


}
