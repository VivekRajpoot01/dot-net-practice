import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product.model';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit, OnDestroy {
  products: Product[] = [];
  searchTerm: string = '';
  showForm: boolean = false;
  editingProduct: Product | null = null;
  private subscription: Subscription = new Subscription();

  // Form model for add/edit
  formData: Omit<Product, 'id'> = {
    name: '',
    price: 0,
    description: '',
    category: '',
    inStock: true
  };

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.subscription.add(
      this.productService.getProducts().subscribe(products => {
        this.products = products;
      })
    );
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  // Open add product form
  openAddForm(): void {
    this.showForm = true;
    this.editingProduct = null;
    this.resetForm();
  }

  // Open edit product form
  editProduct(product: Product): void {
    this.showForm = true;
    this.editingProduct = product;
    this.formData = {
      name: product.name,
      price: product.price,
      description: product.description,
      category: product.category,
      inStock: product.inStock
    };
  }

  // Save product (add or update)
  saveProduct(): void {
    if (this.editingProduct) {
      // Update existing product
      const updatedProduct: Product = {
        ...this.formData,
        id: this.editingProduct.id
      };
      this.productService.updateProduct(updatedProduct);
      alert('Product updated successfully!');
    } else {
      // Add new product
      this.productService.addProduct(this.formData);
      alert('Product added successfully!');
    }
    this.closeForm();
  }

  // Delete product with confirmation
  deleteProduct(id: number, productName: string): void {
    if (confirm(`Are you sure you want to delete "${productName}"?`)) {
      this.productService.deleteProduct(id);
      alert('Product deleted successfully!');
    }
  }

  // Search products
  searchProducts(): void {
    this.productService.searchProducts(this.searchTerm);
  }

  // Reset search
  resetSearch(): void {
    this.searchTerm = '';
    this.productService.searchProducts('');
  }

  // Close form
  closeForm(): void {
    this.showForm = false;
    this.editingProduct = null;
    this.resetForm();
  }

  // Reset form data
  private resetForm(): void {
    this.formData = {
      name: '',
      price: 0,
      description: '',
      category: '',
      inStock: true
    };
  }

  // Get stock status class
  getStockStatusClass(inStock: boolean): string {
    return inStock ? 'in-stock' : 'out-of-stock';
  }

  // Add this method to the ProductListComponent class
getAveragePrice(): string {
  if (this.products.length === 0) return '0';
  const total = this.products.reduce((sum, product) => sum + product.price, 0);
  return (total / this.products.length).toFixed(2);
}

}
