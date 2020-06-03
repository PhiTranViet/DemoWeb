<template>
    <div id="app">
        <div id="content">
            <router-view />
        </div>
    </div>
</template>

<script>
    export default {
        name: "App",
    };
</script>

<style>
    #app {
        font-family: "Avenir", Helvetica, Arial, sans-serif;

        -webkit-font-smoothing: antialiased;

        -moz-osx-font-smoothing: grayscale;

        text-align: center;

        color: #2c3e50;

        display: flex;
    }

    #content {
        width: 100%;

        padding: 0px 100px;
    }

    ::-webkit-scrollbar {
        width: 6px;
    }

    ::-webkit-scrollbar-thumb {
        background: #01b075;

        border-radius: 3px;
    }

    ::-webkit-input-placeholder {
        /* Edge */

        color: #c1c1c1;

        font-style: italic;
    }
</style>
