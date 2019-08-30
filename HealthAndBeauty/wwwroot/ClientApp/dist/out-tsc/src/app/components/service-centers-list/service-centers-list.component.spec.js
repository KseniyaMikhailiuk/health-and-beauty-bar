import { async, TestBed } from '@angular/core/testing';
import { ServiceCentersListComponent } from './service-centers-list.component';
describe('ServiceCentersListComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ServiceCentersListComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(ServiceCentersListComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=service-centers-list.component.spec.js.map