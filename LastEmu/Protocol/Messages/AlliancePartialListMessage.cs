using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AlliancePartialListMessage : AllianceListMessage
	{
		public const uint Id = 6427;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6427;
			}
		}

		public AlliancePartialListMessage()
		{
		}

		public AlliancePartialListMessage(AllianceFactSheetInformations[] alliances) : base(alliances)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}