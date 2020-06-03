<template>
    <div class="modal" tabindex="-1" role="dialog" id="deleteEmp">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Xóa nhân viên</h5>

                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>

                <div class="modal-body">
                    <div>Bạn chắc chắn muốn xóa nhân viên: <b>{{employee.employeeCode}}</b> <b>{{employee.employeeName}}</b></div>
                </div>

                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-dismiss="modal" v-on:click="getIdEmpDelete()">Có</button>

                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Không</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: "modal",

        props: {
            employee: Object,
        },

        data() {
            return {
                listEmployees: [],
            };
        },

        methods: {
            getIdEmpDelete() {
                this.$emit("getIdEmpDelete", this.employee);
            },
        },
    };
</script>

<style scoped>
    .modal-dialog {
        top: 100px;
    }
</style>
