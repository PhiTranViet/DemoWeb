import Vue from 'vue'

import Router from 'vue-router'

import listEmployee from '@/components/listEmployee'



Vue.use(Router)



export default new Router({

    routes: [{

        path: '/',

        name: 'listEmployee',

        component: listEmployee

    }]

})