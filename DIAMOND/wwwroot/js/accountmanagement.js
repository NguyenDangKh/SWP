﻿// Sample account data
let accounts = [
    { id: 1, name: 'Alice Johnson', email: 'alice@example.com', role: 'Admin', status: 'Active' },
    { id: 2, name: 'Bob Smith', email: 'bob@example.com', role: 'User', status: 'Inactive' },
    { id: 3, name: 'Charlie Brown', email: 'charlie@example.com', role: 'User', status: 'Active' }
];

// Function to render account list
function renderAccountList() {
    const accountList = document.getElementById('account-list');
    accountList.innerHTML = '';
    accounts.forEach(account => {
        accountList.innerHTML += `
            <tr>
                <td>${account.id}</td>
                <td>${account.name}</td>
                <td>${account.email}</td>
                <td>${account.role}</td>
                <td>${account.status}</td>
                <td>
                    <button class="btn btn-sm btn-primary" onclick="editAccount(${account.id})">Edit</button>
                </td>
            </tr>
        `;
    });
}

// Function to edit an account
function editAccount(id) {
    const account = accounts.find(a => a.id === id);
    document.getElementById('edit-account-id').value = account.id;
    document.getElementById('edit-account-name').value = account.name;
    document.getElementById('edit-account-email').value = account.email;
    document.getElementById('edit-account-role').value = account.role;
    document.getElementById('edit-account-status').value = account.status;
    $('#editAccountModal').modal('show');
}

// Event listener for form submission
document.getElementById('edit-account-form').addEventListener('submit', function (event) {
    event.preventDefault();
    const id = parseInt(document.getElementById('edit-account-id').value);
    const name = document.getElementById('edit-account-name').value;
    const email = document.getElementById('edit-account-email').value;
    const role = document.getElementById('edit-account-role').value;
    const status = document.getElementById('edit-account-status').value;

    const accountIndex = accounts.findIndex(a => a.id === id);
    accounts[accountIndex] = { id, name, email, role, status };

    renderAccountList();
    $('#editAccountModal').modal('hide');
});

// Initial render
renderAccountList();
