using System;
using DevExpress.Xpf.Grid;

namespace CustomGridResourceText {
    public class CustomGridLocalizer : GridControlResXLocalizer {
        public override string GetLocalizedString(GridControlStringId id) {
            if(id == GridControlStringId.GridNewRowText)
                return "Click here to add a new task";
            
            if(id == GridControlStringId.GridGroupPanelText)
                return "Here goes custom text for the group panel";

            return base.GetLocalizedString(id);
        }
    }
}
