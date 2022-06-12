<template>
    
    <div class="content-box-max ">
        <div class="container">
            <div class="flex">
                <h4 class="mr-2">Договора</h4>
                <a asp-controller="Contract"
                   asp-action="CreateContract">
                    <input type="button" value="Новый договор" class="add-btn" />
                </a>
            </div>
          

            <table class="table table-hover table-bordered results full">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>
                            Заключен
                        </th>
                        <th>
                            Фамилия на памятнике
                        </th>
                        <th>
                            Установка/самовывоз
                        </th>
                        <th>
                            Крайний срок
                        </th>
                        <th>
                            Заказчик
                        </th>
                        <th>
                            Телефон
                        </th>
                    </tr>
                    <!--<tr class="warning no-result">
                        <td colspan="7"><i class="fa fa-warning"></i> Совпадения не найдены</td>
                    </tr>-->
                </thead>
                <tbody>
                    <tr class="table-stroke" v-for="c in contracts.slice().reverse()" :key="c.id">
                        <td class="font-weight-bold">
                            <label>{{ c.number }}</label>
                        </td>
                        <td>
                            <label>{{ c.dateConclusion }}</label>
                        </td>
                        <td>
                            <label>{{ c.deceased }}</label>
                        </td>
                        <td>
                            <label v-if="c.pickup">Самовывоз</label>
                            <label v-else>Установка</label>
                        </td>
                        <td>
                            <label>{{ c.deadline }}</label>
                        </td>
                        <td>
                            <label>{{ c.customer }}</label>
                        </td>
                        <td>
                            <label>{{ c.phone }}</label>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class="full">
            
        </div>
        
    </div>

    


</template>


<script>
    export default {
        name: "Contracts",
        data() {
            return {
                contracts: [
                    {
                        id: 1,
                        number: "22/ДО/1",
                        dateConclusion: "12.06.2022",
                        deceased: "Иванов Иван Иванович",
                        pickup: true,
                        deadline: "12.09.2022",
                        customer: "Иванов Петр Васильевич",
                        phone: "+375(29)1568726"
                    },
                    {
                        id: 2,
                        number: "22/ДО/2",
                        dateConclusion: "27.05.2022",
                        deceased: "Самойлов Валентин Иосифович",
                        pickup: false,
                        deadline: "27.08.2022",
                        customer: "Иванов Петр Васильевич",
                        phone: "+375(29)1568726"
                    },
                    {
                        id: 3,
                        number: "22/ДО/3-p",
                        dateConclusion: "12.06.2022",
                        deceased: "Иванов Иван Иванович",
                        pickup: true,
                        deadline: "12.09.2022",
                        customer: "Иванов Петр Васильевич",
                        phone: "+375(29)1568726"
                    }
                ]
            };
        },
        methods: {
            async getAllContracts() {
                // отправляет запрос и получаем ответ
                const response = await fetch("/contract", {
                    method: "GET",
                    headers: { "Accept": "application/json" }
                });
                // если запрос прошел нормально
                if (response.ok === true) {
                    // получаем данные
                    const contracts = await response.json();
                    console.log(contracts);
                    //let rows = document.querySelector("tbody");
                    //contracts.forEach(c => {
                    //    // добавляем полученные элементы в таблицу
                    //    rows.append(row(c));
                    //});
                }
            }
            //getAllContracts() {
            //    axios.get('/contract')
            //        .then((response) => {
            //            console.log(response.data)
            //            //this.contracts = response.data;
            //        })
            //        .catch(function (error) {
            //            alert(error);
            //        });
            //}
        },
        mounted() {
            await this.getAllContracts();
        }
    }
</script>

<style>

</style>