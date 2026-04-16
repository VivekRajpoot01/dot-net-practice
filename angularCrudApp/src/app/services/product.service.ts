import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private products: Product[] = [];
  private productsSubject = new BehaviorSubject<Product[]>([]);
  public products$ = this.productsSubject.asObservable();
  private currentId = 1;

  constructor() {
    // Initialize with sample data
    this.loadSampleData();
  }

  private loadSampleData(): void {
    this.products = [
      {
        id: this.currentId++,
        name: 'Laptop',
        price: 999.99,
        description: 'High-performance laptop with 16GB RAM',
        category: 'Electronics',
        inStock: true
      },
      {
        id: this.currentId++,
        name: 'Coffee Mug',
        price: 15.99,
        description: 'Ceramic coffee mug, 350ml',
        category: 'Kitchen',
        inStock: true
      },
      {
        id: this.currentId++,
        name: 'Notebook',
        price: 5.99,
        description: '100-page ruled notebook',
        category: 'Stationery',
        inStock: false
      }
    ];
    this.productsSubject.next([...this.products]);
  }

  // Get all products
  getProducts(): Observable<Product[]> {
    return this.products$;
  }

  // Get single product by ID
  getProductById(id: number): Observable<Product | undefined> {
    const product = this.products.find(p => p.id === id);
    return of(product);
  }

  // Create new product
  addProduct(product: Omit<Product, 'id'>): void {
    const newProduct: Product = {
      ...product,
      id: this.currentId++
    };
    this.products.push(newProduct);
    this.productsSubject.next([...this.products]);
  }

  // Update existing product
  updateProduct(updatedProduct: Product): boolean {
    const index = this.products.findIndex(p => p.id === updatedProduct.id);
    if (index !== -1) {
      this.products[index] = updatedProduct;
      this.productsSubject.next([...this.products]);
      return true;
    }
    return false;
  }

  // Delete product
  deleteProduct(id: number): boolean {
    const initialLength = this.products.length;
    this.products = this.products.filter(p => p.id !== id);
    if (this.products.length !== initialLength) {
      this.productsSubject.next([...this.products]);
      return true;
    }
    return false;
  }

  // Search products by name or category
  searchProducts(searchTerm: string): void {
    if (!searchTerm.trim()) {
      this.productsSubject.next([...this.products]);
      return;
    }
    
    const filtered = this.products.filter(product => 
      product.name.toLowerCase().includes(searchTerm.toLowerCase()) ||
      product.category.toLowerCase().includes(searchTerm.toLowerCase())
    );
    this.productsSubject.next(filtered);
  }
}
