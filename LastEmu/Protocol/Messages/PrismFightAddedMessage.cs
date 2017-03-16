using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PrismFightAddedMessage : NetworkMessage
	{
		public const uint Id = 6452;

		public PrismFightersInformation fight;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6452;
			}
		}

		public PrismFightAddedMessage()
		{
		}

		public PrismFightAddedMessage(PrismFightersInformation fight)
		{
			this.fight = fight;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fight = new PrismFightersInformation();
			this.fight.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.fight.Serialize(writer);
		}
	}
}