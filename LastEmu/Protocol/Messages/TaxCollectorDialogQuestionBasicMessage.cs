using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorDialogQuestionBasicMessage : NetworkMessage
	{
		public const uint Id = 5619;

		public BasicGuildInformations guildInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5619;
			}
		}

		public TaxCollectorDialogQuestionBasicMessage()
		{
		}

		public TaxCollectorDialogQuestionBasicMessage(BasicGuildInformations guildInfo)
		{
			this.guildInfo = guildInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildInfo = new BasicGuildInformations();
			this.guildInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.guildInfo.Serialize(writer);
		}
	}
}