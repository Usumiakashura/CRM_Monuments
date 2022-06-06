/**
  * теперь этот файл/поток будет кодироваться в UTF-8
  */

import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import Texts from "@/components/Texts.vue";

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/Texts",
        name: "Texts",
        component: Texts,
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;