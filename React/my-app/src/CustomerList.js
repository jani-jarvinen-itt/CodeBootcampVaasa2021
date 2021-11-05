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
            list.push(<tr>
                <td>{customer.customerId}</td>
                <td>{customer.companyName}</td>
                <td>{customer.contactName}</td>
                <td>{customer.city}</td>
            </tr>);
        }

        return (
            <div>
                <h1>Customer List</h1>
                <p>Number of customer: {this.state.customers.length}</p>
                <table className="table table-striped w-75">
                    <thead>
                        <tr>
                            <th>Customer Id</th>
                            <th>Company Name</th>
                            <th>Contact Name</th>
                            <th>City</th>
                        </tr>
                    </thead>
                    <tbody>
                        {list}
                    </tbody>
                </table>
            </div>);
    }
}

export default CustomerList;
