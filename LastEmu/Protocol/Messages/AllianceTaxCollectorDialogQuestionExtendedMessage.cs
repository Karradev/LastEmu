using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
	{
		public const uint Id = 6445;

		public BasicNamedAllianceInformations alliance;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6445;
			}
		}

		public AllianceTaxCollectorDialogQuestionExtendedMessage()
		{
		}

		public AllianceTaxCollectorDialogQuestionExtendedMessage(BasicGuildInformations guildInfo, uint maxPods, uint prospecting, uint wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, uint kamas, double experience, uint pods, uint itemsValue, BasicNamedAllianceInformations alliance) : base(guildInfo, maxPods, prospecting, wisdom, taxCollectorsCount, taxCollectorAttack, kamas, experience, pods, itemsValue)
		{
			this.alliance = alliance;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.alliance = new BasicNamedAllianceInformations();
			this.alliance.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.alliance.Serialize(writer);
		}
	}
}