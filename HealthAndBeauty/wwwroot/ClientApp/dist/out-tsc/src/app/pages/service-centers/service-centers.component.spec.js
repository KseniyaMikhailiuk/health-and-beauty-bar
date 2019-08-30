import { async, TestBed } from '@angular/core/testing';
import { ServiceCentersComponent } from './service-centers.component';
describe('ServiceCentersComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ServiceCentersComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(ServiceCentersComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=service-centers.component.spec.js.map