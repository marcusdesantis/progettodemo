import { OperaTemplatePage } from './app.po';

describe('Opera App', function() {
  let page: OperaTemplatePage;

  beforeEach(() => {
    page = new OperaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
