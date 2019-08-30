import { async, TestBed } from '@angular/core/testing';
import { ServiceCenterComponent } from './service-center.component';
describe('ServiceCenterComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ServiceCenterComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(ServiceCenterComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=service-center.component.spec.js.map