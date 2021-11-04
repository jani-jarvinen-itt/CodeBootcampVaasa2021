import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
        console.log("In LifecycleDemo.constructor");
        this.state = { title: "" };
    }

    componentDidMount() {
        console.log("In LifecycleDemo.componentDidMount");

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
        console.log("In LifecycleDemo.render");
        return (
            <div>
                <h1>Hello, this is the Lifecycle component!</h1>
                <p>Title: {this.state.title}</p>
            </div>);
    }
}

export default LifecycleDemo;
