import React from 'react';

class CustomerList extends React.Component {

    constructor(props) {
        super(props);
        console.log("In CustomerList.constructor");
        this.state = { title: "" };
    }

    componentDidMount() {
        console.log("In CustomerList.componentDidMount");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(json => {
                console.log(json.title);
                this.setState({ title: json.title });
                console.log("Component state has been modified.");
            });
        console.log("Fetch call has been made.");
    }

    render() {
        console.log("In CustomerList.render");
        return (
            <div>
                <h1>Customer List</h1>
                <p>Title: {this.state.title}</p>
            </div>);
    }
}

export default CustomerList;
