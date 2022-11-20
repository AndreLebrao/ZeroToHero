import { ZeroToHeroTemplatePage } from './app.po';

describe('ZeroToHero App', function() {
  let page: ZeroToHeroTemplatePage;

  beforeEach(() => {
    page = new ZeroToHeroTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
