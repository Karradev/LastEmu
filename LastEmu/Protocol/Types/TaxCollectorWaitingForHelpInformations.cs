using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorWaitingForHelpInformations : TaxCollectorComplementaryInformations
	{
		public const short Id = 447;

		public ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;

		public override short TypeId
		{
			get
			{
				return 447;
			}
		}

		public TaxCollectorWaitingForHelpInformations()
		{
		}

		public TaxCollectorWaitingForHelpInformations(ProtectedEntityWaitingForHelpInfo waitingForHelpInfo)
		{
			this.waitingForHelpInfo = waitingForHelpInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.waitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
			this.waitingForHelpInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.waitingForHelpInfo.Serialize(writer);
		}
	}
}