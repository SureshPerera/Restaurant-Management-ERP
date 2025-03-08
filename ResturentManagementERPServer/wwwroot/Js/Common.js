window.ShowToastr = (type, message) => {
    toastr.options.toastClass = "toastr";
    if (type === "success") {
        toastr.success(message, "Operation successfull", { setTimeout:2000 })
    }
    if (type === "error") {
        toastr.error(message, "Operation failed", { setTimeout:2000 })
    }
}