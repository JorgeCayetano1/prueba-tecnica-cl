import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'phoneFormat',
})
export class PhoneFormatPipe implements PipeTransform {
  transform(phone: string): string {
    if (!phone || typeof phone !== 'string') {
      return phone;
    }

    const [prefix, ...numberParts] = phone.split('-');
    const numberPart = numberParts.join('') || prefix;
    const formattedNumber = numberPart.replace(/(\d{4})(?=\d)/g, '$1 ').trim();

    return numberParts.length
      ? `${prefix} ${formattedNumber}`.trim()
      : formattedNumber;
  }
}
