function Message() {
    const name = 'Max';

    if (name == 'Max'){
        return <h1>Hello {name}</h1>;
    }
    else{
        return <h1>Hello World</h1>
    }
}

export default Message;