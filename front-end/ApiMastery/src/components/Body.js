import React, {Component} from 'react';

class Body extends Component {
    render()
    {
        return (
            <div>
                <section id="body-parent">
                    <h1 id="parent-name">Test</h1>
                </section>
                <section id="body-child-list">
                    <span class="body-child-item"></span>
                </section>
            </div>
        );
    }
}

export default Body;