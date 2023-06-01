import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'useCustom'
})
export class UseCustomPipe implements PipeTransform {

  transform(value: any,) {
    let decimal=value;
    let binary: string;
    let hexadecimal: string;
    let octal: string;

    if (value) {
      binary = value.toString(2);
      hexadecimal = value.toString(16).toUpperCase();
      octal = value.toString(8);
    } else {
      binary = '';
      hexadecimal = '';
      octal = '';
    }

    return { binary, hexadecimal, octal };
    
  }

}
