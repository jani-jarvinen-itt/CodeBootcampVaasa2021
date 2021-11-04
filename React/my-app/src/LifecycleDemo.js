import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
        console.log("In LifecycleDemo.constructor");
    }

    componentDidMount() {
        console.log("In LifecycleDemo.componentDidMount");
    }

    render() {
        console.log("In LifecycleDemo.render");
        return <h1>Hello, this is the Lifecycle component!</h1>;
    }
}

export default LifecycleDemo;
