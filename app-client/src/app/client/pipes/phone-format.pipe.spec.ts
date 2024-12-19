import { PhoneFormatPipe } from './phone-format.pipe';

describe('PhoneFormatPipe', () => {
  let pipe: PhoneFormatPipe;

  beforeEach(() => {
    pipe = new PhoneFormatPipe();
  });

  it('creando la instancia', () => {
    expect(pipe).toBeTruthy();
  });

  it('formateo del numero', () => {
    const phone = '+123-4567890';
    const formattedPhone = pipe.transform(phone);
    expect(formattedPhone).toBe('+123 4567 890');
  });

  it('numero sin prefijo', () => {
    const phone = '4567890';
    const formattedPhone = pipe.transform(phone);
    expect(formattedPhone).toBe('4567 890');
  });

  it('retorna el mismo valor si el parametro no es un string', () => {
    const phone = 1234567890 as any;
    const formattedPhone = pipe.transform(phone);
    expect(formattedPhone).toBe(phone);
  });

  it('retorna el mismo valor si el parametro es null o undefined', () => {
    expect(pipe.transform(null as any)).toBe(null as any);
    expect(pipe.transform(undefined as any)).toBe(undefined as any);
  });

  it('retorna el mismo valor si el parametro es un string vacio', () => {
    expect(pipe.transform('')).toBe('');
  });
});
