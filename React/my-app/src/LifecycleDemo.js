import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
    }

    render() {
        return <h1>Hello, this is the Lifecycle component!</h1>;
    }

    componentDidMount() {
    }
}

export default LifecycleDemo;
