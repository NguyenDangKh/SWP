// Sample product data
let products = [
    { id: 1, name: 'Product 1', price: 100, quantity: 10, status: 'Available' },
    { id: 2, name: 'Product 2', price: 150, quantity: 0, status: 'Out of Stock' },
    { id: 3, name: 'Product 3', price: 200, quantity: 5, status: 'Available' }
];

// Function to render product list
function renderProductList() {
    const productList = document.getElementById('product-list');
    productList.innerHTML = '';
    products.forEach(product => {
        productList.innerHTML += `
            <tr>
                <td>${product.id}</td>
                <td>${product.name}</td>
                <td>${product.price}</td>
                <td>${product.quantity}</td>
                <td>${product.status}</td>
                <td>
                    <button class="btn btn-sm btn-primary" onclick="editProduct(${product.id})">Edit</button>
                </td>
            </tr>
        `;
    });
}

// Function to edit a product
function editProduct(id) {
    const product = products.find(p => p.id === id);
    document.getElementById('edit-product-id').value = product.id;
    document.getElementById('edit-product-name').value = product.name;
    document.getElementById('edit-product-price').value = product.price;
    document.getElementById('edit-product-quantity').value = product.quantity;
    document.getElementById('edit-product-status').value = product.status;
    $('#editProductModal').modal('show');
}

// Event listener for form submission
document.getElementById('edit-product-form').addEventListener('submit', function (event) {
    event.preventDefault();
    const id = parseInt(document.getElementById('edit-product-id').value);
    const name = document.getElementById('edit-product-name').value;
    const price = parseFloat(document.getElementById('edit-product-price').value);
    const quantity = parseInt(document.getElementById('edit-product-quantity').value);
    const status = document.getElementById('edit-product-status').value;

    const productIndex = products.findIndex(p => p.id === id);
    products[productIndex] = { id, name, price, quantity, status };

    renderProductList();
    $('#editProductModal').modal('hide');
});

// Initial render
renderProductList();
