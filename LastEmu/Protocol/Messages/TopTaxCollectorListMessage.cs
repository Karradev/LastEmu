using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
	{
		public const uint Id = 6565;

		public bool isDungeon;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6565;
			}
		}

		public TopTaxCollectorListMessage()
		{
		}

		public TopTaxCollectorListMessage(TaxCollectorInformations[] informations, bool isDungeon) : base(informations)
		{
			this.isDungeon = isDungeon;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.isDungeon = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.isDungeon);
		}
	}
}