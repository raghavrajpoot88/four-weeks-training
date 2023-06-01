import { UseCustomPipe } from './use-custom.pipe';

describe('UseCustomPipe', () => {
  it('create an instance', () => {
    const pipe = new UseCustomPipe();
    expect(pipe).toBeTruthy();
  });
});
