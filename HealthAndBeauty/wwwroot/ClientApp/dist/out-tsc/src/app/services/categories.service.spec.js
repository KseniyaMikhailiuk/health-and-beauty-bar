import { TestBed } from '@angular/core/testing';
import { CategoriesService } from './categories.service';
describe('CategoriesService', () => {
    beforeEach(() => TestBed.configureTestingModule({}));
    it('should be created', () => {
        const service = TestBed.get(CategoriesService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=categories.service.spec.js.map