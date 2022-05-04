import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Inquiry } from '../models/inquiry';
import {FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators} from '@angular/forms';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  form: FormGroup;
  inquiries: Inquiry[] = [];
  validationErrors: string[] = [];
  types: any = ['Complaint', 'Feedback', 'Contact'];

  constructor(private http: HttpClient, private fb: FormBuilder) {}

  ngOnInit(): void {
    this.initForm();
    this.http.get<Inquiry[]>(environment.apiUrl).subscribe({
      next: response => this.inquiries = response,
      error: error => console.log(error)
    });
  }

  initForm() {
    this.form = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.email, Validators.required]],
      phone: ['', Validators.required],
      number: [''],
      type: [null, Validators.required],
      description : ['', Validators.required],
    })
  }

  submitInquiry() {
    console.log(this.form.value);
    this.http.post<Inquiry[]>(environment.apiUrl, this.form.value).subscribe({
      next: response => this.inquiries = response,
      error: error => console.log(error)
    });
    this.form.reset();
  }
}


