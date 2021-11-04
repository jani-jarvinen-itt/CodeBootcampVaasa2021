import React from 'react';

class CustomerList extends React.Component {

    constructor(props) {
        super(props);
        console.log("In CustomerList.constructor");
        this.state = { customers: [] };
    }

    componentDidMount() {
        console.log("In CustomerList.componentDidMount");

        fetch('https://localhost:44378/api/customers')
            .then(response => response.json())
            .then(json => {
                console.log(json);
                this.setState({ customers: json });
                console.log("Component state has been modified.");
            });
        console.log("Fetch call has been made.");
    }

    render() {
        console.log("In CustomerList.render");

        let list = [];
        for (let index = 0; index < this.state.customers.length; index++) {
            const customer = this.state.customers[index];
            list.push(<p>Id: {customer.customerId} – Name: {customer.companyName}</p>);
        }

        return (
            <div>
                <h1>Customer List</h1>
                <p>Number of customer: {this.state.customers.length}</p>
                {list}
            </div>);
    }
}

export default CustomerList;
